let count = 0

let answer1 = Number(prompt('Сколько будет 2 + 3'))
if (answer1 == 5){
    count += 10
    alert('Верно')
} else {
    alert('Не верно')
}

answer1 = Number(prompt('Сколько будет 7 - 10'))
if (answer1 == -3){
    count += 10
    alert('Верно')
} else {
    alert('Не верно')
}

alert(`Финальный счет: ${count}`)