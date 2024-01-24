# Exempel på Filhantering i C#
Detta repository innehåller tre exempel på hur man kan hantera att spara till och läsa från filer i C#, och är tänkt att användas i pedagogiskt syfte. Exemplen visar olika metoder och illustrerar övergången från enkel filhantering till en mer objektorienterad ansats.

## Grenar (Branches) i Repositoryt
Repositoryt är indelat i flera grenar, var och en demonstrerar en specifik metod. Tanken är att gå igenom exemplen/brancherna i följande ordning

1. **with-file**: Visar ett enkelt exempel på att använda File-klassen från System.IO för att skriva till och läsa från textfiler.

2. **with-streams**: Demonstrerar användningen av StreamWriter och StreamReader för att hantera filer. Detta tillvägagångssätt är användbart för mer kontrollerad filhantering, till exempel när man hanterar stora filer eller behöver finjustera buffring och prestanda.

3. **with-json-and-oop**: Introducerar JSON-serialisering och deserialisering för att hantera komplexa datatyper, och visar hur man strukturerar projektet på ett objektorienterat sätt. Detta är användbart för att spara objekt och deras tillstånd på ett strukturerat och formatoberoende sätt.

## Användning
För att använda koden i detta repository, klona först repositoryt till din lokala maskin. Du kan sedan växla mellan de olika grenarna för att utforska de olika metoderna:

git clone https://github.com/ditt-användarnamn/ditt-repository.git

cd ditt-repository

git checkout branch-name   # Ersätt 'branch-name' med namnet på den gren du vill utforska

Koden är skriven i C# och kan köras i en lämplig utvecklingsmiljö som Visual Studio eller med .NET CLI.


--------------------
## Ansvar vid användning av koden
Koden i detta repository är fri att använda, modifiera och distribuera för alla ändamål, både kommersiella och icke-kommersiella, under förutsättning att licensvillkoren i allmän MIT-licens följs. Detta innebär att koden tillhandahålls "SOM DEN ÄR", utan någon form av garanti, och ingen upphovsperson eller bidragsgivare kan hållas ansvarig för eventuella skador eller problem som uppstår som ett resultat av dess användning.
