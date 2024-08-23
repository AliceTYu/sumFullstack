let n = Number(prompt('Количество человек? '))
let summ = Number(prompt('Сумма счета? '))
let tip = Number(prompt('Сколько чаевых, %? '))

if (n <= 0 || summ <= 0 || tip < 0 || isNaN(n) || isNaN(summ) || isNaN(tip)) {
    alert(`Ошибочные данные, введите еще раз`)
} else {
    let result = (summ + (summ * tip / 100)) / n
}

alert(`На ${n} человек, сумма чаевых составит: ${result}`)