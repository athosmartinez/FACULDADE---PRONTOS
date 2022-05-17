let a = "5";
let b = 5;
let c = 2;

console.log(1, a > c);
console.log(2, b > c);
console.log(3, b >= c);
console.log(4, b < c);
console.log(5, a <= c);
console.log(6, b != c);
console.log(7, b != a);
console.log(8, b == a);
console.log(9, b === a);

console.log(10, "Z" > "A");
console.log(11, "Z" > "a");
console.log(12, "Pato" > "Pata");
console.log(13, "Dezena" > "Dez");

let x;
console.log(14, x == undefined);
console.log(15, x === null);
console.log(16, x == null);
console.log(17, x === undefined);

console.log(18, a == b && b > c); //v && v => v
console.log(19, a === b && b > c); //v && f => f
console.log(20, a == b && b < c); //f && v => f
console.log(21, a === b && b < c); //f && f => f

console.log(18, a == b || b > c); // v || v => v
console.log(19, a === b || b > c); // f || v => v
console.log(20, a == b || b < c); // v || f => v
console.log(21, a === b || b < c); // f || f =>f

console.log(22, !(b.c));