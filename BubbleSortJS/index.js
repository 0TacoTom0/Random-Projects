function BubbleSort(array){
    for(let i = 0; i <= array.length-1; i++){
        let swapped=false
        for(let j = 0; j <= array.length-1; j++){
            if(array[j]>array[j+1]){
                let temp = array[j]
                array[j] = array[j+1]
                array[j+1] = temp
                swapped=true
            }
        }
        if(!swapped){
            break
        }
    }
    return array
}

numbers = [5, 3, 9, 12, 1, 7, 5, 3]
console.log(BubbleSort(numbers))