import React, {useState, useEffect} from "react";
import axios from 'axios'
import ContentItem from "./components/ContentItem";
import FooterItem from "./components/FooterItem";
import HeaderItem from "./components/HeaderItem";

const value = 'Какие-то карточки'
// const lable = [
//     {id: 1, cardTitle: 'Котя2', cardText: 'одеялко', imageUrl: 'https://cs12.pikabu.ru/post_img/big/2021/08/22/7/162963170714044704.jpg'},
// ]

const baseUrl = "https://jsonplaceholder.typicode.com/photos"
// const baseUrl = "https://jsonplaceholder.typicode.com/posts"

const HomePage = () => {
    const [lable, setLable] = useState([])

    useEffect(() => {
        axios.get(baseUrl).then(res => {
            setLable(res.data.slice(3, 8))
        })
    })

    return(
        <div className="container col-10">
            <HeaderItem headerText={value}/>
            <ContentItem
                setOfLable={lable}
            />
            <FooterItem/>
        </div>
    )
}

export default HomePage