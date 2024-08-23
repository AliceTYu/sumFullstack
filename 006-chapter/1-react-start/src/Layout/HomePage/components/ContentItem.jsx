import React from "react";

const ContentItem = (props) => {
    return(
        <div>
            {props.setOfLable.map((item, index) => 
                <div key={item.id} className="card m-3" >
                    <img src= {item.url} className="card-img-top" alt="Картинка"/>
                    <div className="card-body">
                        <h5 className="card-title">{item.title.slice(0,25)}</h5>
                        <a href="#" className="btn btn-primary">Go somewhere</a>
                    </div>
                </div>
            ) }      
        </div>
    )
}

export default ContentItem