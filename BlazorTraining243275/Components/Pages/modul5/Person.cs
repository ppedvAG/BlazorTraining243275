using System.ComponentModel.DataAnnotations;

namespace BlazorTraining243275.Components.Pages.modul5
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Da muss was rein")]
        [StringLength(10,ErrorMessage ="zwishcne 3 und 10",MinimumLength =3)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Da muss was rein")]
        public int Gross { get; set; }
        [Required(ErrorMessage = "Da muss was rein")]
        [Range(150,190,ErrorMessage ="zwischen 150 und 190")]
        public DateTime GebDate { get; set; }
    }
}
