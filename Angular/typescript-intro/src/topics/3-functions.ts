function addNumber (a:number , b:number) {

    return a + b;

}

const addNumbersArrows = ( a : number, b: number ) => {
   // return (a + b).toString;
    return `${a + b}`;
}

function multiply(firstNumber: number, secondNumer?: number, base: number = 2):number{
    return firstNumber * base;
}

const multiplyResult: number = multiply(4)
const multiplyResult2: number = multiply(4, 2)
const multiplyResult3: number = multiply(4, 2, 3)

const result  =  addNumber (1, 2);
const result2 = addNumbersArrows(1,2);


console.log({result, result2});
console.log('Resultado ', result);
console.log('Resultado2', result2);
console.log('Multiply', multiplyResult)
console.log('Multiply2', multiplyResult2)
console.log('Multiply3', multiplyResult3)
export{};