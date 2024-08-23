import React, {useEffect, useState} from "react";

const MyComponents = () => {
    const [count, setCount] = useState(0)

    useEffect(() => {
        document.title=`Значение: ${count}`
    })

    return(
        <div>
            <button onClick={() => setCount(count-1)}>Жми меня</button>
            <h1>{count}</h1>
            <button onClick={() => setCount(count+1)}>Жми меня</button>
        </div>
    )
}

export default MyComponents