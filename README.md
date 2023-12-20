DIO - Trilha .NET - Fundamentos
www.dio.me

Desafio de projeto
Para este desafio, você precisará utilizar seus conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO.

Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

Proposta
Você precisará construir uma classe chamada "Estacionamento", conforme o diagrama abaixo: Diagrama de classe de estacionamento

A aula contém três variáveis, sendo:

precoInicial : Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

precoPorHora : Tipo decimal. É o preço por hora que o veículo permanece estacionado.

veículos : É uma lista de strings, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

AdicionarVeiculo : Método responsável para receber uma placa digitalizada pelo usuário e salvar veículos variáveis .

Removedor de Veículo : Método responsável para verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele encontra no estacionamento. Após isso, realize o seguinte cálculo: precoInicial * precoPorHora , exibindo para o usuário.

ListarVeiculos : Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exiba a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações inovadoras:

Cadastrar veículo
Removedor de veículo
Listar veículos
Encerrar
Solução
O código está pela metade, e você deverá dar continuidade obedecendo às regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.
