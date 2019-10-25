using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SmithASP.Models;
using SmithASP.Models.DbContexts;
using SmithASP.Models.Workout;
using SmithASP.ViewModels;
using SmithASP.ViewModels.WorkoutViewModels;

namespace SmithASP.Controllers
{
    public class WorkoutController : Controller
    {

        private readonly WorkoutContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public WorkoutController(WorkoutContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {

            var userId = _userManager.GetUserId(User);
            DashboardViewModel DVM = new DashboardViewModel();
            DVM.ExerciseViewModel.MuscleGroups = _context.MuscleGroups.ToList();
            DVM.ScheduledWorkouts.ScheduledWorkouts = new ScheduledWorkout[3];
            DVM.Exercises = _context.GetExercisesForUser(User.Identity.Name);
            //var workouts = _context.Workouts.Where(x => x.AspNetUserId == userId).ToList();
            return View(DVM);
        }

        public IActionResult CreateWorkout()
        {
            Exercise[] allExercises = _context.Exercises.ToArray();
            WorkoutCreationViewModel vm = new WorkoutCreationViewModel();
            vm.allExercises = allExercises;
            return View(vm);
        }

        public IActionResult CreateExercise(ExerciseViewModel view)
        {
            string[] allIds = Request.Form["muscleId"];
            EntityEntry e = _context.Exercises.Add(new Exercise() { Name = view.Name, UserName = User.Identity.Name});
            foreach (string muscleIdString in allIds)
            {
                int muscleId = Convert.ToInt32(muscleIdString);
                _context.ExerciseMuscleGroups.Add(new ExerciseMuscleGroup(e.CurrentValues.GetValue<int>("Id"), muscleId));
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}