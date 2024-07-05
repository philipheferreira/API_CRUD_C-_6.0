namespace APICRUD.Models { 

public class TarefaModel{
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public int Status { get; set; } // Será criado um Enum para setar em que status está a tarefa
    }
}
