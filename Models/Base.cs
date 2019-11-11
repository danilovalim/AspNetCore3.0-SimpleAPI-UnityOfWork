using System;

namespace RepoApp.Models
{
    public class Base
    {
        public Base()
        {
            CriadoEm = DateTime.Now;
            ModificadoEm = DateTime.Now;
        }

        public int Id { get; set; }

        public DateTime CriadoEm { get; set; }

        public DateTime ModificadoEm { get; set; }
    }
}

