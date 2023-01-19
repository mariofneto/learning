// function addNums(num1 = 2, num2 = 7)
// {
//     return num1 + num2;
// }

// console.log(addNums(10,9));

// const subNums = (num1, num2) => num1 - num2;


// console.log(subNums(10,5));

// function Person(firstName, lastName, dob)
// {
//     this.firstName = firstName;
//     this.lastName = lastName;
//     this.dob = dob;
// }

// const person1 = new Person('Mário','Neto','09-10-2001');
// console.log(person1.firstName, person1.lastName, person1.dob);


// class Personaly {
//     constructor(firstName, lastName, dob){
//         this.firstName = firstName;
//         this.lastName = lastName;
//         this.dob = dob;
//     }
    
//     getFullName()
//     {
//         return this.firstName + " " + this.lastName
//     }
// }


// const person2 = new Personaly('Odila', 'Zanela', '23/10/2001');

// console.log(person2.getFullName())

let titulo = document.querySelector('h1')
let paragrafo = document.querySelector('p')

titulo.textContent = 'mudei o titulo';

paragrafo.style.width = '200px';
paragrafo.style.padding = '10px';
paragrafo.style.backgroundColor = 'red';


let botao = document.querySelector('button')

botao.addEventListener('mouseover', (e) =>{
    e.preventDefault();
    botao.style.backgroundColor = 'red';
})

botao.addEventListener('mouseleave', (e) =>{
    e.preventDefault();
    botao.style.backgroundColor = 'blue';
})

botao.addEventListener('click', (e) =>{
    e.preventDefault();
    botao.style.backgroundColor = 'green';
})


