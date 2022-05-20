let pessoa = {
    nome: `João`,
    idade: 35,
    casado: true,
};
console.log(pessoa);
console.log(pessoa.nome);
console.log(pessoa[`idade`]);

let prop = `nome`;
console.log([prop]);

pessoa.numerodefilhos = 2;
console.log(pessoa);

let pessoa2 = {};
pessoa2.nome = `maria`;
pessoa2.idade = 28;
pessoa2.casado = false;
pessoa2.numerodefilhos = 5;
console.log(pessoa2);

function criapessoa(n, i, c, f) {
    let p = {};
    p.nome = n;
    p.idade = i;
    p.casado = c;
    p.numerodefilhos = f;
    return p;
}

function criapessoa1(n1, i1, c1, f1) {
    return {
        nome: n1,
        idade: i1,
        casado: c1,
        numerodefilhos: f1,
        maioridade: function() {
            return this.idade >= 18;
        },
    };
}

let pessoa3 = criapessoa(`geraldo`, 60, true, 1);
let pessoa4 = criapessoa1(`Pedro`, 20, true, 9);
console.log(1, pessoa);
console.log(2, pessoa2);
console.log(3, pessoa3);
console.log(4, pessoa4, pessoa4.maioridade());

function Pessoaobj(n2, i2, c2, f2) {
    this.nome = n2;
    this.idade = i2;
    this.casado = c2;
    this.numerodefilhos = f2;
    this.maioridade = () => this.idade >= 18;
}

let pessoa5 = new Pessoaobj(`Athos`, 17, false, 0);
console.log(5, pessoa5);
console.log(6, pessoa5.maioridade());

for (let chave in pessoa5) {
    if (typeof pessoa5[chave] != "function")
        console.log(`O valor de "${chave}" é "${pessoa5[chave]}"`);
}

let pessoa6 = pessoa5; // copia da referencia para o objeto
console.log(7, pessoa6);

pessoa5.nome = "Tadeu";
console.log(8, pessoa6);

let pessoa7 = {}; // de fato clona o objeto, tomar cuidado com subojbeto
for (let chave in pessoa3) {
    pessoa7[chave] = pessoa3[chave];
}
console.log(9, pessoa7);