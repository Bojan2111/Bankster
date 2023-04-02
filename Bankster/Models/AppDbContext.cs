using FinalniTest.Models.Login;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Bankster.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Banka> Banke { get; set; }
        public DbSet<TipRacuna> TipoviRacuna { get; set; }
        public DbSet<Pol> Polovi { get; set; }
        public DbSet<Klijent> Klijenti { get; set; }
        public DbSet<Racun> Racuni { get; set; }
        public DbSet<Transakcija> Transakcije { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Transakcija>().HasData(
                new Transakcija()
                {
                    Id = 1,
                    Datum = new DateTime(year: 2022, month: 11, day: 12),
                    UplatilacRacunId = 1,
                    PrimalacRacunId = 3,
                    Iznos = 2139.38M,
                },
                new Transakcija()
                {
                    Id = 2,
                    Datum = new DateTime(year: 2022, month: 12, day: 23),
                    UplatilacRacunId = 5,
                    PrimalacRacunId = 2,
                    Iznos = 3912.29M,
                },
                new Transakcija()
                {
                    Id = 3,
                    Datum = new DateTime(year: 2023, month: 2, day: 12),
                    UplatilacRacunId = 4,
                    PrimalacRacunId = 1,
                    Iznos = 1239.88M,
                },
                new Transakcija()
                {
                    Id = 4,
                    Datum = new DateTime(year: 2023, month: 3, day: 23),
                    UplatilacRacunId = 3,
                    PrimalacRacunId = 5,
                    Iznos = 2319.17M,
                },
                new Transakcija()
                {
                    Id = 5,
                    Datum = new DateTime(year: 2023, month: 4, day: 1),
                    UplatilacRacunId = 2,
                    PrimalacRacunId = 4,
                    Iznos = 3192.01M,
                }
            );

            builder.Entity<Racun>().HasData(
                new Racun()
                {
                    Id = 1,
                    Broj = "0000034567143",
                    KontrolniBroj = 97,
                    Saldo = 34584.58M,
                    TipRacunaId = 1,
                    KlijentId = 1,
                    BankaId = 8
                },
                new Racun()
                {
                    Id = 2,
                    Broj = "1030506040743",
                    KontrolniBroj = 57,
                    Saldo = 86344.22M,
                    TipRacunaId = 1,
                    KlijentId = 4,
                    BankaId = 21
                },
                new Racun()
                {
                    Id = 3,
                    Broj = "1400560700343",
                    KontrolniBroj = 22,
                    Saldo = 13584.58M,
                    TipRacunaId = 2,
                    KlijentId = 1,
                    BankaId = 25
                },
                new Racun()
                {
                    Id = 4,
                    Broj = "5671003400043",
                    KontrolniBroj = 54,
                    Saldo = 4584.39M,
                    TipRacunaId = 2,
                    KlijentId = 2,
                    BankaId = 15
                },
                new Racun()
                {
                    Id = 5,
                    Broj = "0500670013443",
                    KontrolniBroj = 79,
                    Saldo = 131984.38M,
                    TipRacunaId = 4,
                    KlijentId = 3,
                    BankaId = 13
                }
            );

            builder.Entity<Klijent>().HasData(
                new Klijent()
                {
                    Id = 1,
                    Ime = "Bojan",
                    Prezime = "Adzic",
                    Rodjenje = new DateTime(year: 1981, month: 11, day: 21),
                    PolId = 1
                },
                new Klijent()
                {
                    Id = 2,
                    Ime = "Pera",
                    Prezime = "Peric",
                    Rodjenje = new DateTime(year: 1976, month: 9, day: 11),
                    PolId = 1
                },
                new Klijent()
                {
                    Id = 3,
                    Ime = "Petra",
                    Prezime = "Petric",
                    Rodjenje = new DateTime(year: 1964, month: 3, day: 26),
                    PolId = 2
                },
                new Klijent()
                {
                    Id = 4,
                    Ime = "Vanja",
                    Prezime = "Bulic",
                    Rodjenje = new DateTime(year: 2000, month: 2, day: 29),
                    PolId = 3
                },
                new Klijent()
                {
                    Id = 5,
                    Ime = "Jelena",
                    Prezime = "Jelic",
                    Rodjenje = new DateTime(year: 1998, month: 6, day: 30),
                    PolId = 2
                }
            );

            builder.Entity<Pol>().HasData(
                new Pol()
                {
                    Id = 1,
                    Naziv = "Muski",
                    Forma = "G-din"
                },
                new Pol()
                {
                    Id = 2,
                    Naziv = "Zenski",
                    Forma = "G-dja"
                },
                new Pol()
                {
                    Id = 3,
                    Naziv = "Neizjasnjen",
                    Forma = "G-din/G-dja"
                }
            );
            
            builder.Entity<TipRacuna>().HasData(
                new TipRacuna()
                {
                    Id = 1,
                    Tip = "Tekuci"
                },
                new TipRacuna()
                {
                    Id = 2,
                    Tip = "Devizni"
                },
                new TipRacuna()
                {
                    Id = 3,
                    Tip = "Kreditni"
                },
                new TipRacuna()
                {
                    Id = 4,
                    Tip = "Stedni"
                }
            );

            builder.Entity<Banka>().HasData(
                new Banka()
                {
                    Id = 1,
                    Naziv = "AIK BANKA, AD",
                    Sediste = "NIŠ",
                    Kod = 105
                },
                new Banka()
                {
                    Id = 2,
                    Naziv = "TELENOR BANKA, AD",
                    Sediste = "BEOGRAD",
                    Kod = 115
                },
                new Banka()
                {
                    Id = 3,
                    Naziv = "PIRAEUS BANK, AD",
                    Sediste = "BEOGRAD",
                    Kod = 125
                },
                new Banka()
                {
                    Id = 4,
                    Naziv = "MARFIN BANK, AD",
                    Sediste = "BEOGRAD",
                    Kod = 145
                },
                new Banka()
                {
                    Id = 5,
                    Naziv = "KBM BANKA, AD",
                    Sediste = "KRAGUJEVAC",
                    Kod = 150
                },
                new Banka()
                {
                    Id = 6,
                    Naziv = "ČAČANSKA BANKA, AD",
                    Sediste = "ČAČAK",
                    Kod = 155
                },
                new Banka()
                {
                    Id = 7,
                    Naziv = "BANCA INTESA, AD",
                    Sediste = "BEOGRAD",
                    Kod = 160
                },
                new Banka()
                {
                    Id = 8,
                    Naziv = "HYPO ALPE – ADRIA – BANK, AD",
                    Sediste = "BEOGRAD",
                    Kod = 165
                },
                new Banka()
                {
                    Id = 9,
                    Naziv = "UNICREDIT BANK SRBIJA, AD",
                    Sediste = "BEOGRAD",
                    Kod = 170
                },
                new Banka()
                {
                    Id = 10,
                    Naziv = "ALPHA BANK SRBIJA, AD",
                    Sediste = "BEOGRAD",
                    Kod = 180
                },
                new Banka()
                {
                    Id = 11,
                    Naziv = "JUBMES BANKA, AD",
                    Sediste = "BEOGRAD",
                    Kod = 190
                },
                new Banka()
                {
                    Id = 12,
                    Naziv = "BANKA POŠTANSKA ŠTEDIONICA, AD",
                    Sediste = "BEOGRAD",
                    Kod = 200
                },
                new Banka()
                {
                    Id = 13,
                    Naziv = "KOMERCIJALNA BANKA, AD",
                    Sediste = "BEOGRAD",
                    Kod = 205
                },
                new Banka()
                {
                    Id = 14,
                    Naziv = "PROCREDIT BANK, AD",
                    Sediste = "BEOGRAD",
                    Kod = 220
                },
                new Banka()
                {
                    Id = 15,
                    Naziv = "FINDOMESTIC BANKA, AD",
                    Sediste = "BEOGRAD",
                    Kod = 240
                },
                new Banka()
                {
                    Id = 16,
                    Naziv = "EUROBANK, AD",
                    Sediste = "BEOGRAD",
                    Kod = 250
                },
                new Banka()
                {
                    Id = 17,
                    Naziv = "RAIFFEISEN BANKA, AD",
                    Sediste = "BEOGRAD",
                    Kod = 265
                },
                new Banka()
                {
                    Id = 18,
                    Naziv = "SOCIETE GENERALE BANKA SRBIJA, AD",
                    Sediste = "BEOGRAD",
                    Kod = 275
                },
                new Banka()
                {
                    Id = 19,
                    Naziv = "SBERBANK SRBIJA, AD",
                    Sediste = "BEOGRAD",
                    Kod = 285
                },
                new Banka()
                {
                    Id = 20,
                    Naziv = "SRPSKA BANKA, AD",
                    Sediste = "BEOGRAD",
                    Kod = 295
                },
                new Banka()
                {
                    Id = 21,
                    Naziv = "NLB BANKA, AD",
                    Sediste = "BEOGRAD",
                    Kod = 310
                },
                new Banka()
                {
                    Id = 22,
                    Naziv = "OTP BANKA SRBIJA, AD",
                    Sediste = "NOVI SAD",
                    Kod = 325
                },
                new Banka()
                {
                    Id = 23,
                    Naziv = "RBA SRBIJA, AD",
                    Sediste = "NOVI SAD",
                    Kod = 330
                },
                new Banka()
                {
                    Id = 24,
                    Naziv = "ERSTE BANK, AD",
                    Sediste = "NOVI SAD",
                    Kod = 340
                },
                new Banka()
                {
                    Id = 25,
                    Naziv = "VOJVOĐANSKA BANKA, AD",
                    Sediste = "NOVI SAD",
                    Kod = 355
                },
                new Banka()
                {
                    Id = 26,
                    Naziv = "DUNAV BANKA, AD",
                    Sediste = "BEOGRAD",
                    Kod = 360
                },
                new Banka()
                {
                    Id = 27,
                    Naziv = "JUGOBANKA JUGBANKA, AD, KOSOVSKA MITROVICA",
                    Sediste = "",
                    Kod = 365
                },
                new Banka()
                {
                    Id = 28,
                    Naziv = "OPPORTUNITY BANKA, AD",
                    Sediste = "NOVI SAD",
                    Kod = 370
                },
                new Banka()
                {
                    Id = 29,
                    Naziv = "VTB BANKA, AD",
                    Sediste = "BEOGRAD",
                    Kod = 375
                },
                new Banka()
                {
                    Id = 30,
                    Naziv = "MIRABANK, AD",
                    Sediste = "BEOGRAD",
                    Kod = 380
                },
                new Banka()
                {
                    Id = 31,
                    Naziv = "NARODNA BANKA SRBIJE",
                    Sediste = "BEOGRAD",
                    Kod = 908
                }
            );

            base.OnModelCreating(builder);
        }
    }
}
