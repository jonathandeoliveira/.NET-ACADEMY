using Aula12_05;

List<Pessoa> listaPessoas = new List<Pessoa>();

//Persistencia.lerArquivoExibeNomes("E:\\Visual Studio\\Repos\\jonathandeoliveira\\.NET-ACADEMY\\Aulas\\Aula12-05\\Dados.dat");

Persistencia.popularArquivoLista("E:\\Visual Studio\\Repos\\jonathandeoliveira\\.NET-ACADEMY\\Aulas\\Aula12-05\\Dados.dat", listaPessoas);

Persistencia.exibirLista(listaPessoas);

