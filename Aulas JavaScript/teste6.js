function mensagem1() {
    console.log("Olá mundo 1!");
}

mensagem1();

function mensagem2() {
    return "Olá mundo 2!";
}

console.log(mensagem2());

function mensagem3(nome) {
    return `Olá ${nome} 3!`;
}

console.log(mensagem3(`Mundo`));
console.log(mensagem3(`Planeta`));
console.log(mensagem3(`Globo`));

function soma1(a = 0, b = 0) {
    return a + b;
}
console.log(soma1(2, 4));
console.log(soma1(4, 4));
console.log(soma1(2));

let resultado;

function soma2(a = 2, b = 2) {
    resultado = a + b;
    return resultado;
}
console.log(resultado);

// Expressão de função
console.log(
    (function(a, b) {
        return a + b;
    })(4, 5)
); //  IIFE -  Immediatily Invoked Function Expression;

let soma3 = function(a, b) {
    return a + b;
};
console.log(soma3(6, 6));

let sum = function(a, b) {
    return a + b;
};

let sub = function(a, b) {
    return a - b;
};

let mul = function(a, b) {
    return a * b;
};

let div = function(a, b) {
    return a / b;
};

function executa(fn, a, b) {
    return fn(a, b);
}

console.log(executa(sum, 12, 3));
console.log(executa(sub, 12, 3));
console.log(executa(mul, 12, 3));
console.log(executa(div, 12, 3));

let fat = function fatorial(n) {
    if (n <= 1) return 1;
    return n * fatorial(n - 1);
};

console.log(fat(5));
console.log(fat(3));

let adicão1 = function(a, b) {
    return a + b;
};
// Arrow function
let adicão2 = (a, b) => a + b;

console.log(adicão1(3, 4));
console.log(adicão2(3, 4));