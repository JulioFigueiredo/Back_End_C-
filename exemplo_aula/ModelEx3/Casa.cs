class Casa {
    private <Comodo> comodos = new List<Comodo>();

    public void AddComodo(Comodo comodo){
        comodos.add(comodo);
    }

    public void MostrarComodos(){
        foreach (Comodo comodo in comodos) {
            Console.WriteLine(comodo.Nome);
        }
    }
}