<p align="center">
  <img ![Estudo De Caso - Java] src="https://github.com/pedrogodri/Imagens/blob/main/modelo-de-logotipo-ss-de-design-plano_23-2149255653-removebg-preview.png?raw=true">
</p>

<h1 align="center">Sharp System</h1>

<p align="center"><a href="https://github.com/pedrogodri/estudo-de-caso/blob/main/LICENSE"><img alt="GitHub Licença" src="https://img.shields.io/badge/Status-Desenvolvimento-blue"></a>
<a href="https://github.com/pedrogodri/estudo-de-caso/blob/main/STATUS"><img alt="GitHub Status de Desenvolvimento" src="https://img.shields.io/badge/Vers%C3%A3o-1.4-blue"></a>
<a href="https://github.com/pedrogodri/estudo-de-caso/blob/main/RELEASE-DATE"><img alt="GitHub Data Entrega" src="https://img.shields.io/badge/Empresa-Senior-blue"></a>
<a href="https://github.com/pedrogodri/estudo-de-caso/blob/main/RELEASE-DATE"><img alt="GitHub Data Entrega" src="https://img.shields.io/badge/Turma-C%23-blue"></a></p>

<p align="center"> :construction: <b>Projeto em desenvolvimento</b> :construction: </p>

# :hammer: Funcionalidades do projeto
`Funcionalidade 1` : Cadastrar Usuários</br>
`Funcionalidade 2` : Editar Usuários</br>
`Funcionalidade 3` : Excluir Usuários</br>
`Funcionalidade 4` : Emitir NFEs</br> 
`Funcionalidade 5` : Visualizar NFEs</br>

# 🏗️ Tecnologias utilizadas
`Tecnologia 1` : C# .NET</br>
`Tecnologia 2` : Vue.JS</br>
`Tecnologia 3` : Visual Studio Code</br>
`Tecnologia 4` : Visual Studio 2022</br>
`Tecnologia 5` : Banco de Dados SQL Server 2019</br>

# 📝 Proposta Geral
<p align="justify">A proposta para o desenvolvimento do nosso projeto é criar uma solução que facilite a emissão, digitação e gestão de Notas Fiscais Eletrônicas de Serviço (NFS-e). Dessa forma, nossa equipe desenvolveu um Sistema Web utilizando a tenclogia do C# .NET MVC com cadastro de usuário, login de usuário e emissão de nota fiscal pelo próprio sistema, e usuando o Vue.JS para as telas do sistema</p>

# 📃 Descrição do Sistema
<p align="justify">Tendo em vista que a forma utilizada atualmente é arcaica, nosso sistema visa facilitar a vida dos usuário nas compras e troca de carros. Tem como objetivo tornar mais prática a venda de automóveis, contando com as opções de criar um usuário realizando o seu cadastro Caso o usuário seja um vendedor, poderá cadastrar um carro, moto, ônibus ou caminhão. Se necessário o vendedor pode descadastrar um veículo também. Mas se o usuário for um comprador, ele poderá comprar os veículos anunciados pelos vendedores, e também poderá anunciar seus veículos.</p>

<h1>📈 Diagramas </h1>

<h2>Diagrama de Classes</h2>

![image](https://github.com/pedrogodri/Imagens/blob/main/DiagramaClasses.PNG?raw=true)

<h2>Diagrama de Casos de Uso</h2>

![image](https://github.com/pedrogodri/Imagens/blob/main/DiagramaCasosUso.PNG?raw=true)


</p>
<ul>
  <li><b>Usuário</b>: atributos que compõem a entidade usuário, sendo eles: marca, modelo, tipo, cor, placa, tipoAutomovel e tipoCombustivel que são do tipo String, possui também anoFabricacao, qtdPeneu, totalDonos e informacaoAutomovel que são do tipo Integer e informacaoAutomovel que é um Float. Possui três métodos publicos sem retorno, dentre eles veiculoEspecificação com características específicas e veiculoUtilizado e estadoVeiculo;
  <li><b>VeiculoDAO</b>: Possui uma associação a classe Veiculo. Tem um atributo privado que é um ArrayList de veículos. Tem cinco métodos públicos e sem retorno são eles: listar, cadastrar, alterar, excluir e comprar;
  <li><b>Carro</b>: Herda da classe Veiculo. Possui três atributos privados do tipo Integer, dentre eles: numeroPortas, numeroBancos e cavalosMotor. Ainda possui dois atributos privados booleanos sendo eles airBag e arCondicionado;
  <li><b>Moto</b>: Herda da classe Veiculo. Possui dois atributos privados Integer sendo eles numeroRodas cilindroMoto e possui um booleano privado chamado bagageiro;
  <li><b>Pesados</b>: Herda de Veiculo e tem dois atributos privados, dentre eles uma String o sistemaFrenagem e um Float, o comprimento;
  <li><b>Onibus</b>: Herda da classe Pesados e possui um atributo privado do tipo Integer o bancosPassageiros;
  <li><b>Caminhão</b>: Herda da classe Pesados, possui dois atributos privados uma String o tipoCaminhao e um Integer o pesoCarga;
</ul>


# ⌨️ Autores
| [<img src="https://avatars.githubusercontent.com/u/86849487?v=4" width=115><br><sub>Pedro Henrique Godri</sub>](https://github.com/pedrogodri) |  [<img src="https://avatars.githubusercontent.com/u/92491382?s=100&v=4" width=115><br><sub>Ana Lydia Moreira</sub>](https://github.com/anamoreiradevs) |  [<img src="https://avatars.githubusercontent.com/u/55857430?s=100&v=4" width=115><br><sub>Gustavo Schimite Soares</sub>](https://github.com/schimitegusta) |  [<img src="https://avatars.githubusercontent.com/u/72774799?s=100&v=4" width=115><br><sub>Nathã Machado</sub>](https://github.com/Nathamachadobeck) | [<img src="https://avatars.githubusercontent.com/u/113642670?v=4" width=115><br><sub>Pedro Henrique Evers</sub>](https://github.com/PHEvers) |
| :---: | :---: | :---: | :---: | :---:
