const Selector = document.querySelector('#chonConGiong');
const SelectorNcc = document.querySelector('#chonNhaCC');
const table = document.querySelector(".add-table-con-giong");
const tableNcc = document.querySelector(".add-table-nhacc");


Selector.addEventListener('click', (e) => {
    const Isoption = e.target.value;
    if (!!Isoption) {
        table.style.display = "table"
      
    }
})

SelectorNcc.addEventListener('click', (e) => {
    const Isoption = e.target.value;
    if (!!Isoption) {
        tableNcc.style.display = "table"

    }
})