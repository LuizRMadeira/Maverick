using Otc.ComponentModel.DataAnnotations;

namespace MaverickNovo.Domain.Models
{
    public class PesquisaPorPessoa
    {
        /// <summary>
        /// Termo a ser pesquisado.
        /// </summary>
        [Required(ErrorKey = "TermoPesquisaObrigatorio")]
        public string TermoPesquisa { get; set; }

    }
}
