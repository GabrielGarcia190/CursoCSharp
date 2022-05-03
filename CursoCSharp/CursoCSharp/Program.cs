using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios  - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamento", Interpolacao.Executar},
                {"Notação Ponto - Fundamento", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamento", LendoDados.Executar},
                {"Formatando Números - Fundamento", FormantandoNumeros.Executar},

        });

            central.SelecionarEExecutar();
        }
    }
}