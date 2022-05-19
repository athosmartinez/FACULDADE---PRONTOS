let frutas = [`laranga`, `maça`, `banana`];
console.log(frutas);
console.log(frutas[0]);
console.log(frutas[1]);
console.log(frutas[2]);

let numeros = [1, 5, 3, 8, 0, 6, 9];
console.log(numeros);

let misturado = [`Jose`, 35, true];
console.log(misturado);

// Inserções
frutas[2] = `limão`;
console.log(frutas);
frutas[3] = `pera`;
console.log(frutas);
console.log(frutas.length);

frutas[6] = `abacaxi`;
console.log(frutas);
console.log(frutas.length);
console.log(typeof frutas[4]);

frutas = []; //Vetor vazio ou também pode ser : new Arrawy();
frutas[frutas.length] = `melão`;
console.log(frutas);
frutas[frutas.length] = `melancia`;
console.log(frutas);
frutas[frutas.length] = `morango`;
frutas[frutas.length] = `mamão`;
frutas[frutas.length] = `uva`;

for (let i = 0; i < frutas.length; i) {
    console.log(i, frutas[i]);
}
frutas.sort();
console.frutas(frutas);

frutas.push(`kwii`);
console.frutas(frutas);

let f = frutas.pop();
console.log(f);
console.log(frutas);

frutas.unshift(`carambola`);
console.log(frutas);

frutas.shift(`orange`);
console.log(frutas);

frutas.forEach((f) => console.log(f));

let frutas2 = frutas.map((f) => f.toLocaleLowerCase());
console.log(frutas);
console.log(fruas2);