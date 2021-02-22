using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FinanceBot.Models
{
    public class Ingot
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int MetalId { get; set; }
        public decimal Nominal { get; set; }
        public decimal? NoCertificateDollars { get; set; }
        public decimal? NoCertificateRubles { get; set; }
        public decimal? CertificateDollars { get; set; }
        public decimal? CertificateRubles { get; set; }
        public decimal? BanksDollars { get; set; }
        public decimal? BanksRubles { get; set; }
        public decimal? EntitiesDollars { get; set; }
        public decimal? EntitiesRubles { get; set; }
    }
}