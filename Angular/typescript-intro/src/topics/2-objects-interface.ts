let colores: string[]= ['Rojo', 'Verde', 'Azul'];

interface Articulo {
    nombre: string,
    existencia: number,
    colores: string[],
    marca?: string  // Aqui puedes recibir de tipo nulo
}

const refaccion: Articulo = {
    nombre: 'Filtro',
    existencia: 50,
    colores: ['Rojo', 'Negro'],
    marca: 'Marca'
}

refaccion.marca = 'LTH';

console.log(refaccion);
console.table(refaccion);

export {};