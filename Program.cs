Console.Clear();

int glicose;

Console.Write("Digite o valor de glicemia (em mg/dL): ");
glicose = Convert.ToInt32(Console.ReadLine());

if (glicose < 92)
{
Console.Write("reavaliar entre 24 e 28 semanas com TTOG 75g de glicose ");
}

else if (glicose >= 92 &&  glicose < 126)
{
    Console.Write("Compatível com Diabetes Gestacional");
}
else
{
    Console.Write("Diabetes Mellitus na Gravidez");
}