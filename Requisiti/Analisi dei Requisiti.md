Analisi dei requisiti
===
* **Calendario** raccoglitore di **eventi** organizzati per **data**
    * Al quale è possibile `aggiungere`:
        * **Eventi di natura non scolastica**
        * **Lezioni**

* **Semestre** definisce un arco di tempo nel quale si svolgono dei **corsi**
    * `Caratterizzato` da:
        * **Data di inizio**
        * **Data di fine**
        * **Periodi di vacanza** (opzionale): in un periodo di vacanza le attività dei corsi vengono sospese
        * **Media dei voti del semestre**: media ponderata calcolata in base ai **crediti**, **media dei voti** e **voto massimo conseguibile** di un **corso**
        * uno o più **Corsi**
    
* **Corso** descrive le attività di un insegnamento
    * `Caratterizzato` da:
        * Uno o più **Docenti**
        * Zero o più **Compiti/Esami**
        * **Crediti** (opzionale)
        * **Media dei voti del corso**: media aritmedica dei **voti** degli **esami** completati
        * **Voto massimo**: conseguibile in un **esame**
        * **Voto finale**: voto conseguito nel corso
               
* **Evento** descrive un **impegno** passato o futuro nel **calendario**
    * `Caratterizzato` da:
        * **Nome**
        * **Data di inizio**
        * **Ora di inizio**
        * **Durata**: in minuti
        * **Luogo**
        * **Descrizione** (opzionale): dettagli riguardanti l'evento
        * **Spesa** effettuata (opzionale): incide sul saldo del **Portafogli**
        * Una o più **Scadenze**: attività da completare entro la data dell'evento
    * `Può avere` una **cadenza periodica**
    * **Evento** è un evento generico
    * `Può essere` di **tipologia specifica**:
        * **Spesa**
        * **Palestra**
        * **Dieta**
        * **Esame**
        
* **Evento Spesa** descrive una serie di acquisti da effettuare
    * `Caratterizzato` da:
       * **Lista di oggetti da comprare**: ogni oggetto è definito da un nome ed una quantità
       * **Lista di oggetti messi nel carrello**: tutti gli oggetti che son stati acquistati, definiti da nome e prezzo (opzionale)
       
* **Evento Palestra** descrive una sessione di allenamento
    * `Caratterizzato` da:
        * **Tabella di allenamento** insieme di **esericizi**

* **Esercizio** descrive un esercizio da effettuare in palestra
    * `Caratterizzato` da:
        * **Serie**: più ripetizioni dello stesso movimento
        * **Peso massimale** (opzionale): raggiunto durante l'esecuzione della serie
        * **KCAL** (opzionale): bruciate
        
* **Evento Compito/Esame** descrive un appello d'esame/compito in classe
    * `Caratterizzato` da:
        * **Tipologia**: scritto o orale
        * **Risultato**: **voto** (opzionale), "non sostenuto", "respinto", "ritirato"
        
* **Lezione** descrive un'attività didattica di un corso
    * `Caratterizzata` da:
        * Uno o più **Docenti**: dai quali viene tenuta
        * **Tipologia**: lezione frontale o laboratorio

* **Compito/Scadenza** attività da svolgere/completare
    * `Caratterizzato` da:
        * **Descrizione**
        * **Data di consegna** (opzionale): in caso di una scadenza(associata ad un evento) la data di consegna è la stessa dell'evento.
        * **Priorità**
        
* **Docente** un professore che insegna una materia/tiene un corso
    * `Caratterizzato` da:
        * **Nome**
        * **Cognome**
        * Uno o più **Recapiti**: numeri di telefono dell'ufficio o indirizzo e-mail
        * Uno o più **Orari di ricevimento studenti**: occasioni di richieste chiarimenti da parte di studenti
    
* **Portafogli** raccoglie tutte le voci di spesa su base mensile
    * `Caratterizzato` da:
        * Eventi che hanno comportato una spesa
        * **Tetto massimo di spesa** (opzionale)
        * **Situazione finanziaria**: in caso di presenza di un tetto massimo mostra la disponibilità residua, altrimenti il totale delle spese effettuate
