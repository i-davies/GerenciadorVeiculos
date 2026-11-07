using System;

namespace GerenciadorVeiculos.Modelos
{
    // A classe Veiculo é abstrata porque ela serve de molde para Carro e Moto
    public abstract class Veiculo
    {
        // Propriedades: guardam as informações do veículo
        public int Id { get; set; }
        public string Modelo { get; set; }
        public decimal ValorDiaria { get; set; }

        // Construtor: usado para preencher os dados ao criar o veículo na memória
        protected Veiculo(string modelo, decimal valorDiaria)
        {
            Modelo = modelo;
            ValorDiaria = valorDiaria;
        }

        // Método abstrato: toda classe filha é obrigada a ter este cálculo
        public abstract decimal CalcularSeguro();
    }
}