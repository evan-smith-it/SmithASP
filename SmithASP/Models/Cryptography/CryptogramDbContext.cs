using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmithASP.Models
{
    public class CryptogramDbContext : DbContext
    {

        public CryptogramDbContext(DbContextOptions<CryptogramDbContext> options) : base(options) { }

        public DbSet<Cryptogram> Cryptograms { get; set; }

        public DbSet<CryptogramEncryptionMethod> CryptogramEncryptionMethods { get; set; }

        public DbSet<EncryptionMethod> EncryptionMethods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EncryptionMethod>().HasData(
                new EncryptionMethod
                {
                    EncryptionMethodId = 1,
                    Name = "Caesar",
                    Description = "Caesar ciphers use a list of symbols, such as the alphabet, and an encryption key. Each letter in the message is identified on the list of symbols and shifted a number times down the list based on the key."
                },
                new EncryptionMethod
                {
                    EncryptionMethodId = 2,
                    Name = "Transposition",
                    Description = "This type of cipher involves changing the positions of the letters in the message. A scrambled alphabet is created by making a cipher square with a keyword. All repeat letters are removed from the keyword and unused letters are placed in subsequent rows until the whole alphabet is present. " +
                    "Next the columns are numbered off in the alphabetical order of the first row, for example man would be numbered 213. Finally, the columns are then used to determine the order of the new alphabet."
                });
            base.OnModelCreating(modelBuilder);
            //create composite key for CryptogramEncryptionMethods
            modelBuilder.Entity<CryptogramEncryptionMethod>().HasKey(x => new { x.CryptogramId, x.EncryptionMethodId });
            //Set schemas so all tables related to crypto operations fall under cryptography. Also changed some names.
            modelBuilder.Entity<Cryptogram>().ToTable("Cryptograms", schema: "Cryptography");
            modelBuilder.Entity<CryptogramEncryptionMethod>().ToTable("CryptogramEncryptionMethod", schema: "Cryptography");
            modelBuilder.Entity<EncryptionMethod>().ToTable("EncryptionMethods", schema: "Cryptography");
            //Set column type and maxlength for encryptionmethod description
            modelBuilder.Entity<EncryptionMethod>().Property(x => x.Description).HasColumnType("varchar(550)");
        }

    }
}
