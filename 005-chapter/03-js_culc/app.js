const inp_summ = document.getElementById('inp_summ')
const inp_tip = document.getElementById('inp_tip')
const inp_person = document.getElementById('inp_person')

const out_tip = document.getElementById('out_tip')
const out_summ = document.getElementById('out_summ')
const out_person = document.getElementById('out_person')

const btn_culc = document.querySelector('.btn_culc')

btn_culc.addEventListener('click', () => {
    if (inp_person.value <= 0 || inp_summ.value <= 0 || inp_tip.value < 0 || isNaN(inp_person.value) || isNaN(inp_summ.value) || isNaN(inp_tip.value)) {
        alert('Введите верные данные')
    } else {
        let summ = Number(inp_summ.value)
        let tips = Number(inp_tip.value)
        let people = Number(inp_person.value)
        out_tip.innerText = summ * tips / 100
        out_summ.innerText = summ + (summ * tips / 100)
        out_person.innerText = (summ + (summ * tips / 100)) / people
    }
})