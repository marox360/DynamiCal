Scelte di progettazione
===

### Voce
Per quanto riguarda le **voci** con le quali è possibile personalizzare un nuovo modello, potranno essere dei seguenti tipi:

   * stringa
   * double
   * boolean
   * data
   
L'utente li visualizzerà nominati come:

   * testo
   * numerico
   * sì-no/tick
   * data

Ogni **voce** viene creata al momento della conferma da parte dell'utente; una volta create una **voce** non è più modificabile. Bisogna eliminarla e ricrearla.

### Agenda
Un'istanza di **Agenda** che raccoglie tutti i calendari e modelli di evento definiti dall'utente, questi devono essere accessibili da più oggetti del sistema. Il pattern **Singleton** permette di semplificare la creazione di **Agenda** avendo un'unica istanza accessibile da tutti gli oggetti del sistema.
