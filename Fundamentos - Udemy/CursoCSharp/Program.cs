using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.EstruturasdeControle;
using CursoCSharp.Fundamentos;
using System;
using System.Collections.Generic;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>( ) {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios  - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormantandoNumeros.Executar},
                {"Convertendo Números - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternario - Fundamentos", OperadorTernario.Executar},

                //Estruturas de Controle
                {"Estrutura IF - Estruturas de Controle", EstruturaIf.Executar },
                {"Estrutura IF  & Else - Estruturas de Controle", EstruturaIfElse.Executar },
                {"Estrutura IF  & Else If - Estruturas de Controle", EstruturaIfElseIf.Executar },
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar },
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar },
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar },
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar },
                {"Estrutura ForEach - Estruturas de Controle", EstruturaForEach.Executar },
                {"Usando Break - Estruturas de Controle", UsandoBrake.Executar },
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar },


                //Classes e Metodos
                {"Membros - Classes e Metodos", Membros.Executar },
                {"Contrutores - Classes e Metodos", Construtores.Executar },
                {"Metodos com Retorno - Classes e Metodos", MetodosComRetorno.Executar },
                {"Metodos Estáticos - Classes e Metodos", MetodosEstaticos.Executar },
                {"Atributos Estáticos - Classes e Metodos", AtributosEstaticos.Executar },
                {"Desafio Atributos - Classes e Metodos", DesafioAtributos.Executar },
                {"Params - Classes e Metodos", Params.Executar },
                {"Parametros Nomeados - Classes e Metodos", ParametrosNomeados.Executar },
                {"Get e Set - Classes e Metodos", GetSet.Executar },
                {"Props - Classes e Metodos", Props.Executar },
                {"Readonly - Classes e Metodos", Readonly.Executar },
                {"Enum - Classes e Metodos", ExemploEnum.Executar },
                {"Struct - Classes e Metodos", ExemploStruct.Executar },
                {"Struct vs Classe - Classes e Metodos", StructvsClasse.Executar },
                {"Valor vs Referência - Classes e Metodos", ValorVsReferentecia.Executar },
                {"Parametro por Referência - Classes e Metodos", ParametrosPorReferencia.Executar },
                {"Parametro com Valor Padrão - Classes e Metodos", ParametrosPadrao.Executar },

                //Coleções
                {"Arrays - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"Array List - Coleções", ColecoesArrayList.Executar},
                {"HashSet - Coleções", ColecoesSet.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
        });

            central.SelecionarEExecutar( );
        }
    }
}