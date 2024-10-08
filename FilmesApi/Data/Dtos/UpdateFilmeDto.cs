using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class UpdateFilmeDto
{
    [Required(ErrorMessage = "O título do filme é obrigatório")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    [StringLength(10, ErrorMessage = "O tamanho do gênero nao pode exceder 10 caracteres")]
    public string Genero { get; set; }
    [Required]
    [Range(70, 300, ErrorMessage = "A duração deve ter entre 70 e 300 minutos")]
    public int Duracao { get; set; }
}
