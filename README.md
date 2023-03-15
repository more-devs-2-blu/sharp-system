<p align="center">
  <img ![Estudo De Caso - Java] src="https://user-images.githubusercontent.com/86849487/199125703-dd54fe0c-7169-466d-b38a-0555d8f9a44f.png">
</p>

<h1 align="center"> Estudo de Caso </h1>

<p align="center"><a href="https://github.com/pedrogodri/estudo-de-caso/blob/main/LICENSE"><img alt="GitHub Licença" src="https://img.shields.io/badge/License-CC0--1.0-blue"></a>
<a href="https://github.com/pedrogodri/estudo-de-caso/blob/main/STATUS"><img alt="GitHub Status de Desenvolvimento" src="https://img.shields.io/badge/Status-Desenvolvimento-blue"></a>
<a href="https://github.com/pedrogodri/estudo-de-caso/blob/main/RELEASE-DATE"><img alt="GitHub Data Entrega" src="https://img.shields.io/badge/Release%20Date-Dezembro-blue"></a></p>
<p align="center"> :construction: <b>Projeto em construção</b> :construction: </p>

# :hammer: Funcionalidades do projeto
`Funcionalidade 1` : Cadastrar Veículos</br>
`Funcionalidade 2` : Listar Veículos</br>
`Funcionalidade 3` : Alterar Veículos</br>
`Funcionalidade 4` : Excluir Veículos</br> 
`Funcionalidade 5` : Cadastrar Usuários</br>

# 🏗️ Tecnologias utilizadas
`Tecnologia 1` : Java 8</br>
`Tecnologia 2` : Java SE JDK 8</br>
`Tecnologia 3` : IDE eclipse workspace</br>

# 📝 Proposta Geral
<p align="justify">O sistema tem como objetivo a venda de automóveis, busca auxiliar e promover de forma mais simples os usuários. Para isso o mesmo contará com diversas funcionalidades, como o usuário realizar o seu cadastro e caso queira vender seu automóvel pode cadastrar o mesmo com as informações necessárias, possibilitando ainda alterar algo se necessário. Já o comprador poderá buscar os carros, motos, caminhões ou ônibus, por fim o mesmo poderá comprar o carro do vendedor. Assim se finaliza a proposta geral, que tem como objetivo principal garantir ao usuário uma visão ampla sobre os automóveis e assim realizar a compra do mesmo</p>

# 📃 Descrição do Sistema
<p align="justify">Tendo em vista que a forma utilizada atualmente é arcaica, nosso sistema visa facilitar a vida dos usuário nas compras e troca de carros. Tem como objetivo tornar mais prática a venda de automóveis, contando com as opções de criar um usuário realizando o seu cadastro Caso o usuário seja um vendedor, poderá cadastrar um carro, moto, ônibus ou caminhão. Se necessário o vendedor pode descadastrar um veículo também. Mas se o usuário for um comprador, ele poderá comprar os veículos anunciados pelos vendedores, e também poderá anunciar seus veículos.</p>

# 📈 Diagrama de Classes
<p align="center">

![image](https://user-images.githubusercontent.com/95860101/204069700-f074fd2d-c5fa-4f24-8319-aa0e3b77028f.png)


</p>
<ul>
  <li><b>Veiculo</b>: Possui uma associação a classe VeiculoDAO. Tem atributos privados, sendo eles: marca, modelo, tipo, cor, placa, tipoAutomovel e tipoCombustivel que são do tipo String, possui também anoFabricacao, qtdPeneu, totalDonos e informacaoAutomovel que são do tipo Integer e informacaoAutomovel que é um Float. Possui três métodos publicos sem retorno, dentre eles veiculoEspecificação com características específicas e veiculoUtilizado e estadoVeiculo;
  <li><b>VeiculoDAO</b>: Possui uma associação a classe Veiculo. Tem um atributo privado que é um ArrayList de veículos. Tem cinco métodos públicos e sem retorno são eles: listar, cadastrar, alterar, excluir e comprar;
  <li><b>Carro</b>: Herda da classe Veiculo. Possui três atributos privados do tipo Integer, dentre eles: numeroPortas, numeroBancos e cavalosMotor. Ainda possui dois atributos privados booleanos sendo eles airBag e arCondicionado;
  <li><b>Moto</b>: Herda da classe Veiculo. Possui dois atributos privados Integer sendo eles numeroRodas cilindroMoto e possui um booleano privado chamado bagageiro;
  <li><b>Pesados</b>: Herda de Veiculo e tem dois atributos privados, dentre eles uma String o sistemaFrenagem e um Float, o comprimento;
  <li><b>Onibus</b>: Herda da classe Pesados e possui um atributo privado do tipo Integer o bancosPassageiros;
  <li><b>Caminhão</b>: Herda da classe Pesados, possui dois atributos privados uma String o tipoCaminhao e um Integer o pesoCarga;
</ul>


# ⌨️ Autores
| [<img src="https://avatars.githubusercontent.com/u/86849487?v=4" width=115><br><sub>Pedro Henrique Godri</sub>](https://github.com/pedrogodri) |  [<img src="https://avatars.githubusercontent.com/u/95860101?v=4" width=115><br><sub>Ana Lydia Moreira</sub>](https://github.com/anamoreiradevs) |  [<img src="https://avatars.githubusercontent.com/u/111302374?v=4" width=115><br><sub>Gustavo Schimite Soares</sub>](https://github.com/schimitegusta) |  [<img src="https://avatars.githubusercontent.com/u/114950761?v=4" width=115><br><sub>	Nathã Machado</sub>](https://github.com/Nathamachadobeck) | [<img src="https://avatars.githubusercontent.com/u/114950761?v=4" width=115><br><sub>Pedro Henrique Evers</sub>](https://github.com/PHEvers) |
| :---: | :---: | :---: | :---: | :---:
