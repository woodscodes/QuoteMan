// autocomplete

const people = [];

//findPeople(people);

async function getCustomers() {
    const response = await fetch('/api/customers');
    const jsonData = await response.json();
    people.push(...jsonData);
    return people;
}

console.log(getCustomers());


//console.log(people);
/*
function findPeople(searchTerm, people) {
    return people.filter(person => {
        const regEx = new RegExp(searchTerm, 'gi');
        return person.firstName.match(regEx) || person.lastName.match(regEx)
    });
};

console.log(findPeople('bob', people));*/