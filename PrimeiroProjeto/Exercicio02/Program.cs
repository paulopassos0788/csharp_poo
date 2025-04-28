/* 
 * Criar uma lista de linguagens de programação, 
 * com as linguagens C#, Java e JavaScript.
 */

List<string> linguagens = new List<string>
{
    "C#",
    "Java",
    "JavaScript"
};

foreach(string linguagem in linguagens)
{
    Console.WriteLine(linguagem);
}