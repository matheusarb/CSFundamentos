using _2ModificadoresAcesso;

Console.WriteLine("Modificadores de acesso\n---------");

// 1. public - tipo ou membro pode ser acessado por qualquer outro código dentro do mesmo assembly ou em outro assembly que fizer referência a ele
// 2. private - tipo ou membro só poderá ser acesso pelo código na mesma classe o struct em q foi declarado
// 3. internal - tipo ou membro poderá ser acessado pelo código dentro do mesmo assembly em que foi declarado, mas não por outro assembly
// 4. protected - tipo ou membro poderá ser acessado pelo código dentro do assembly em que foi declarado, OU de uma CLASSE DERIVADA em outro assembly
// 5. file - restringe o escopo e a visibilidade  de um tipo de nível superior ao arquivo no qual ele for declarado

// Como definir quem deve acessar os tipos/membros?]
// Uma boa prática é limitar a visibilidade a apenas quem precisa realmente acessar o tipo ou membro
// Limitar acesso apenas ao que for necessário;
// Expor apenas o que precisar ser exposto;

MinhaClasse classe = new MinhaClasse();
classe.
//Console.WriteLine(MeuEnum.teste1);