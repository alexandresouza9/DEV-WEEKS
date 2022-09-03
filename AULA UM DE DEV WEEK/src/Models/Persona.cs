namespace src.Models;

public class Persona
{
    public Persona()
    {
        this.nome = "";
        this.idade = 0;

    }
    // noe, idade, cpf, ativa
    public string nome {get; set}
    public int idade { get; set; }
    public string? cpf { get; set; }
    public bool ativado { get; set; }
    
}