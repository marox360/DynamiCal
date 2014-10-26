Analisi dei requisiti
===
* **Agenda**
  * È un'entità che tiene organizzati i propri calendari e modelli di eventi
  * `È caratterizzato da`:
    * zero o più **Calendari**
    * zero o più **Modelli di eventi**
* **Calendario**
  * `È identificato da`:
    * **Nome**
  * `È caratterizzato da`:
    * zero o più **Eventi**
  * `Può essere`:
    * **Locale**
    * **Condiviso**
* **Calendario locale**
* **Calendario condiviso**
  * Deve essere possibile `condividere` il calendario con altri utenti 
  * `È caratterizzato da`:
    * uno o più **Amici**, persone con le quali condividere un calendario
* **Evento** ≡ **Impegno**
  * `È caratterizzato da`:
    * **Nome**
    * **Data**, data e ora di inizio dell'evento
    * **Durata**, durata in minuti dell'evento
    * **Periodicità**
    * **Modello di evento**
  * `Può avere`
    * **Descrizione**
    * **Luogo**, dove si svolge l'evento
* **Periodicità**, cadenza ripetuta nel tempo di un determinato evento
  * `Può ripetersi`
    * **Mai**
    * **Ogni tot giorni**
    * **Ogni tot settimane**
    * **Ogni tot mesi**
    * **Ogni tot anni**
* **Modello di evento** ≡ **Modello**
  * `È identificato da`:
    * **Nome**
  * `Contiene`:
    * zero o più **Voci**, la lista è ordinata
* **Voce** ≡ **Campo aggiuntivo di un evento**
  * Descrive un campo aggiuntivo di un evento 
  * `È caratterizzata da`:
    * **Nome**
    * **Tipo**
* **Filtro** ≡ **Strategia di filtraggio** ≡ **Tipologia di filtro**
  * `Può essere`:
    * **Filtro per calendario**
    * **Filtro per arco temporale**
    * **Filtro per modello**
    * **Filtro per ricerca**
* **Filtro per calendario**
  * `Filtra` per:
    * **Calendari**, sottoinsieme di calendari di un'agenda
* **Filtro per arco temporale**
  * `Filtra` per:
    * **Data inizio**
    * **Data fine**
* **Filtro per modello**
  * `Filtra` per:
    * **Modello di evento**
* **Filtro per ricerca**
  * `Filtra` per:
    * **Frase** ≡ **Parola**
* **Criterio di filtraggio**
  * `È caratterizzata da`:
    * uno o più **filtri**
* **Risultato di un filtraggio**
  * Sottoinsieme di eventi ottenuto applicando uno o più filtri agli eventi di uno o più calendari
  * Il cambiamento dell'insieme del calendari o dell'insieme degli eventi di uno qualsiasi dei calendari (`inserimento`, `modifica`, `cancellazione`) `provoca un aggiornamento` automatico del risultato di un filtraggio
  * Deve essere `visualizzabile`
* **Amico**
  * Descrive un utente con il quale si vuole condividere un calendario 
  * `È identificato da`:
    * **Email**
