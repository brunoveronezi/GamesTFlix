using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesTrailerFlix.Models
{
    public class GamesModel
    {
        public GamesModel()
        {
        }
        public int Id { get; set; }
        public string NomeGame { get; set; }
        public string GeneroGame { get; set; }
        public string ClassificacaoGame { get; set; }
        public DateTime DataLancamentoGame { get; set; }
    }
}
