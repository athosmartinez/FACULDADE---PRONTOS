let acessoPermetido = false;
let idade = 21;
if (idade >= 18) acessoPermetido = true;
else acessoPermetido = false;
console.log(acessoPermetido);

let dividendo = 12;
let divisor = 4;
let quociente = divisor != 0 ? dividendo / divisor : Infinity;
console.log(quociente);

let nota = 75;
let frequencia = 0.8;
let resultado;
if (nota >= 60) {
    if (frequencia >= 0.75) resultado = "aprovado";
    else resultado = "reprovado por frequencia";
} else {
    if (frequencia >= 0.75) resultado = "reprovado por nota";
    else resultado = "reprovado por nota e frequencia";
}
console.log(resultado);

let a = 2,
    b = 1,
    operador = "+";
switch (operador) {
    case "+":
        resultado = a + b;
        break;
    case "*":
        resultado = a * b;
        break;
    case "/":
        resultado = a / b;
        break;
    case "-":
        resultado = a - b;
        break;
    default:
        console.log("operador invalido")
        resultado = null;
}
console.log(`resultado = ${resultado}`);