using GestoreEventi;

var evento = new Evento("dd", DateTime.Parse("Jan 1, 2029"), 700, 10);
evento.setTitolo("ddd");
Console.WriteLine(evento.PrenotaPosti(5));

;
