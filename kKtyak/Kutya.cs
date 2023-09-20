using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kKtyak
{
    class Kutya
    {
        int id;
        string kutyaFajtaja;
        string kutyaNeve;
        int kutyaEletkora;
        string vizsgalatIdeje;

        public Kutya(int id, string kutyaFajtaja, string kutyaNeve, int kutyaEletkora, string vizsgalatIdeje)
        {
            this.id = id;
            this.kutyaFajtaja = kutyaFajtaja;
            this.kutyaNeve = kutyaNeve;
            this.kutyaEletkora = kutyaEletkora;
            this.vizsgalatIdeje = vizsgalatIdeje;
        }


        public int Id { get => id; }
        public string KutyaFajtaja { get => kutyaFajtaja; }
        public string KutyaNeve { get => kutyaNeve; }
        public int KutyaEletkora { get => kutyaEletkora; }
        public string VizsgalatIdeje { get => vizsgalatIdeje; }
    }
}
