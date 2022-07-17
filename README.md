# DEVCar

<p>A montadora/revenda de veículos DEV-Car deseja automatizar todo o sistema de
armazenamento de informações referentes aos carros fabricados. O sistema deve conter os
seguintes tipos de carros, cada um com suas características:</p>
<ul>
<li>● Moto/Triciclo
<ul>
<li>○ Uma moto/triciclo possui como característica principal sua potência.</li>
<li>○ Deve-se informar o total rodas da moto/triciclo.</li>
</li>
</ul>
<li>● Carro
<ul>○ Carro possui como características principais:
<ul><li>■ Total de portas.</li>
<li>■ Se será flex ou somente gasolina.</li>
<li>■ Potência (em cavalos).</li></ul>
</ul>
</li>
<li>● Camionete:
<ul>○ Carro possui como características principais:
<ul><li>■ Total de portas.</li>
<li>■ Capacidade de carregamento na caçamba (em litros).</li>
<li>■ Potência (em cavalos).</li>
<li>■ Se será gasolina ou diesel.</li></ul>
<ul>○ Um detalhe importante é que o DEVCar só fabrica camionetes na corte Roxa.
<ul><li>■ Criar um teste unitário para validar a regra citada acima.
</li>
Todos os veículos devem ser derivadas da classe Veículo, que possui os seguintes atributos e
métodos:
● Veículo
○ Atributos
○ Número do chassi (o sistema deverá gerar de forma automática e não poderá
repetir)
○ Data de Fabricação
○ Nome
○ Placa (Placa não pode repetir para mais de um carro)
○ Valor (Não pode ser um valor negativo).
○ CPF do Comprador (quando cadastrado deve ficar em zero).
○ Cor
● Métodos
○ Vender veículo
○ Listar informações
○ Alterar informações:
■ Cor e valor
O DEVCar também deseja manter um histórico das transferências que deverá armazenar (utilizar
conceitos de composição):
● Dados do Veículo
● CPF do comprador
● Valor
● Data
O sistema também deverá apresentar os seguintes relatórios:
● Listar todos os carros. O usuário deverá informar quais veículos quais tipos de veículos
deseja listar:
○ Motos/Triciclo
○ Carros
○ Camionete
○ Todos
● Carros disponíveis
● Carros vendidos
● Carro vendido com o maior preço
● Carro vendido com o menor preço