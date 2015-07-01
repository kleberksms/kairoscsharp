using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Kairos.MVC.ViewModels
{
    public class TicketViewModel
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Título")]
        [Required(ErrorMessage = "Campo título é obrigatório")]
        [MaxLength(150, ErrorMessage = "Permetido no máximo {1} caracteres")]
        [MinLength(5, ErrorMessage = "Deve haver no mínimo {1} caracteres")]
        public string Title { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "Campo descrição é obrigatório")]
        public string Description { get; set; }

        //[ScaffoldColumn(false)]
        //public int AuthorId { get; set; }
        
        [DisplayName("Ticket relaionado")]
        public int ParentId { get; set; }

        [DisplayName("Prioridade")]
        public int PriorityId { get; set; }

        //[ScaffoldColumn(false)]
        //public int MeasureId { get; set; }

        //[ScaffoldColumn(false)]
        //public int StatusId { get; set; }

        [ScaffoldColumn(false)]
        public bool IsClosed { get; set; }

        [ScaffoldColumn(false)]
        public bool IsActive { get; set; }

        [ScaffoldColumn(false)]
        public DateTime Created { get; set; }

        [ScaffoldColumn(false)]
        public DateTime Modified { get; set; }

    }
}