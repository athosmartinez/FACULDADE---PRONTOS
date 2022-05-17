let i = 0;
while (i <= 5) {
    console.log(i);
    i++;
}

let g = 3;
do {
    console.log(g);
    g--;
} while (g < 0);


for (h = 0; h < 15; h++) {
    if (i == 7) break;
    console.log(i);
}

for (h = 0; h < 15; h++) {
    if (i == 7) continue;
    console.log(i);
}

i %= 3; // i = i%3;
console.log(i);