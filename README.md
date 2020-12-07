# Maverick

Projeto Maverick - Luiz RIcardo Madeira

### OBSERVAÇÕES:

* Adicionado um "PackageReference" (Otc.Caching) no arquivo do projeto WebApi, pois o template utilizado apresentava erros devido a ausência deste pacote.

* A rota que já existia (search/movie) busca somente filmes. A nova rota solicitada (search/person) busca mídias do tipo filmes (movie) e séries (tv).
Observei que o resultado dos filmes e séries são diferentes, para as séries o nome vem na tag "name", já nos filmes vem na tag "title".
Por isso alterei os objetos de Filme para receber as duas tags e assim poder atender a nova rota, evitando desta maneira que as séries venham sem o nome.
Poderia ser tratado de outras maneiras criando novos objetos, mas aproveitei o existente por causa de tempo.

* Foi adicionado dois Facts na classe "FilmesServiceTests.cs" para testar Sucesso e Erro na execução da nova rota (search/person).

* O arquivo da coleção de requisições para teste via Postman está no repositório LuizRMadeira/Maverick (arquivo: Maverick.postman_collection.json).
