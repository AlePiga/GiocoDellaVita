
# Gioco della Vita

Benvenuto nel progetto _Gioco della Vita_! Questo programma simula un ecosistema virtuale in cui diverse creature interagiscono tra loro secondo le regole imposte dalla catena alimentare.

## Descrizione del progetto

Il gioco della vita è un'applicazione che simula l'interazione tra tre categorie di entità in un ecosistema: carnivori, erbivori e piante. 

Ognuna di queste creature ha comportamenti unici, come la caccia per i carnivori, la ricerca di piante per gli erbivori e la crescita di semi per le piante. L'obiettivo principale del programma è osservare come queste dinamiche si evolvono nel tempo, creando un ecosistema virtuale che riflette in modo semplificato alcuni aspetti della natura.

## Come utilizzare il programma

1.  Apri il file `GiocoDellaVita.sln` in Visual Studio.
2.  Nella finestra iniziale "Impostazioni", imposta la grandezza della griglia e scegli il tema dell'ecosistema.
3. Una volta configurati i parametri, premi su "Inizia" per avviare il campo di gioco.
4.  Premi "Avvia" per avviare la simulazione.
5. Ora puoi osservare le interazioni tra le creature e l'evolversi dell'ecosistema in tempo reale!
6. Una volta terminata la simulazione, premi su "Reset" e successivamente di nuovo su "Inizia" per riavviarla!

## Creature

-   **Carnivori**: Predatori che cacciano gli erbivori per nutrirsi. 
-   **Erbivori**: Creature che si nutrono di piante e devono sfuggire ai carnivori per sopravvivere.
-   **Piante**: Crescono spontaneamente sulla griglia e sono la principale fonte di energia per gli erbivori. Possono anche spawnare dei semi nelle celle circostanti del campo.
-   **Semi**: Meccanismo di riproduzione delle piante. Si diffondono sulla griglia e possono germogliare in nuove piante.

## Schede

 -   **Form iniziale (Impostazioni)**: Permette all'utente di scegliere i parametri iniziali per la simulazione, ossia il tema e la grandezza della griglia. Sono presenti 6 temi, ognuno con le proprie ambientazioni e creature:
	 - Foresta
	 - Savana
	 - Oceano
	 - Deserto
	 - Irlanda
	 - Cina

-   **Campo di Gioco**: Contiene una griglia con l'ecosistema, dove le creature interagiscono tra loro. Sono presenti tre pulsanti per:
	- Avviare la simulazione
	- Resettare la simulazione
	- Aprire la scheda di log

	È inoltre possibile modificare diverse opzioni dai menù a tendina, tra cui la musica di sottofondo e la velocità della simulazione.

-   **Log**: Una pagina che documenta ogni azione che accade nel corso della simulazione. È possibile modificare la grandezza del testo nel menù a tendina.

Puoi visualizzare il diagramma UML delle classi [cliccando qui](https://files.catbox.moe/1s2961.pdf)

## Tecnologie utilizzate

-   **Linguaggio di programmazione**: C#
-   **Framework**: Windows Forms
-   **Piattaforma di sviluppo**: Microsoft Visual Studio 2022
