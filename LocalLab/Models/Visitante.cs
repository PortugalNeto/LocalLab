﻿namespace LocalLab.Models
{
    public class Visitante
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string? Sobrenome { get; set; }
        public bool? PertenceAIgreja { get; set; }
    }
}
