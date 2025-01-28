# Dockerisert Applikasjon

Dette prosjektet er en dockerisert applikasjon som består av tre hovedtjenester:
1. **Nginx** som proxy
2. **.NET API** for backend
3. **MySQL** for database

## Docker Hub Konto
Docker imaget for denne applikasjonen er tilgjengelig på Docker Hub:  
[https://hub.docker.com/u/frabraha](https://hub.docker.com/u/frabraha)

## Forutsetninger
- Docker og Docker Compose må være installert på systemet.  
  [Installer Docker](https://docs.docker.com/get-docker/)  
  [Installer Docker Compose](https://docs.docker.com/compose/install/)

## Instruksjoner
1. Klon prosjektet til din lokale maskin:
   ```bash
   git clone [<repository-url>](https://github.com/frabraham/Dockerisert-Applikasjon.git)
   cd <repository-folder>
2. Start applikasjonen ved å kjøre:
   ```bash
   docker-compose up
3. Åpne nettleseren og naviger til:
   ```bash
   http://localhost:8080

## Teknisk oversikt
Nginx
* Image: nginx:latest
* Proxy for API-tjenesten.
* Volumes inkluderer en egendefinert nginx-konfigurasjon som mountes til /etc/nginx/nginx.conf.

## .NET API
* Bygges fra en lokal mappe ./Api.
* Avhengig av MySQL-databasen.
## MySQL
* Image: mysql:8.0
* Databaseinformasjon:
   * Root-bruker: root / rootpassword
   * Standard database: app_db
   * Bruker: user / userpassword
* Data lagres i en Docker-volum kalt db_data.

## Nettverk
* Alle tjenestene er koblet til et felles Docker-nettverk: app_network.

## Tilpasning
Miljøvariabler
For å tilpasse oppsettet kan du oppdatere miljøvariablene i docker-compose.yml, for eksempel MYSQL_ROOT_PASSWORD eller API-tilkoblingsstrengen.

## Feilsøking
* Stopp alle containere:
	docker-compose down
* Fjern tilknyttede volum og bygg på nytt:
	docker-compose down --volumes
	docker-compose up --build

## Lisens
Dette prosjektet følger ingen spesifikk lisens.
