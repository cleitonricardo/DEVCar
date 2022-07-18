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
○ Um detalhe importante é que o DEVCar só fabrica camionetes na corte Roxa.
<ul><li>■ Criar um teste unitário para validar a regra citada acima.
</li>
</ul>
</ul>
</ul>

<p>Todos os veículos devem ser derivadas da classe Veículo, que possui os seguintes atributos e
métodos:</p>
<ul>● Veículo
<ul><li>○ Atributos</li>
<ul><li>○ Número do chassi (o sistema deverá gerar de forma automática e não poderá
repetir)</li>
<li>○ Data de Fabricação</li>
<li>○ Nome</li>
<li>○ Placa (Placa não pode repetir para mais de um carro)</li>
<li>○ Valor (Não pode ser um valor negativo).</li>
<li>○ CPF do Comprador (quando cadastrado deve ficar em zero).</li>
<li>○ Cor</li></ul>
<li>● Métodos</li>
<ul><li>○ Vender veículo</li>
<li>○ Listar informações</li>
<li>○ Alterar informações:</li>
<ul><li>■ Cor e valor</li></ul></ul>
<p>O DEVCar também deseja manter um histórico das transferências que deverá armazenar (utilizar
conceitos de composição):</p>
<ul>
<li>● Dados do Veículo</li>
<li>● CPF do comprador</li>
<li>● Valor</li>
<li>● Data</li>
</ul>
<p>O sistema também deverá apresentar os seguintes relatórios:</p>
<ul><li>● Listar todos os carros. O usuário deverá informar quais veículos quais tipos de veículos deseja listar:</li>
<ul>
<li>○ Motos/Triciclo</li>
<li>○ Carros</li>
<li>○ Camionete</li>
<li>○ Todos</li></ul>
<li>● Carros disponíveis</li>
<li>● Carros vendidos</li>
<li>● Carro vendido com o maior preço</li>
<li>● Carro vendido com o menor preço</li>