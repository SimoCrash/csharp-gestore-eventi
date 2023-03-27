using GestoreEventi;

var evento = new Evento("dd", DateTime.Parse("Jan 1, 2029"), 700, 144);
evento.setTitolo("ddd");
Console.WriteLine(evento.getPostiPrenotati(PrenotaPosti(5)));
Console.WriteLine(evento.getPostiPrenotati(DisdiciPosti(5)));
Console.WriteLine(evento.getPostiPrenotati());


;
