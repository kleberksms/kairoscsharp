using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Kairos.MVC.ViewModels
{
    public class PriorityViewModel
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Tipo da prioridade")]
        [Required(ErrorMessage = "Campo título é obrigatório")]
        public string Name { get; set; }

        [DisplayName("Propriedade Ativa")]
        public bool IsActive { get; set; }

        [ScaffoldColumn(false)]
        public DateTime Created { get; set; }

        [ScaffoldColumn(false)]
        public DateTime Modified { get; set; }
    }
}