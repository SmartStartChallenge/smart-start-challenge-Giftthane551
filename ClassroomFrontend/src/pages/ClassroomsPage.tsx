import { useEffect, useState } from 'react';
import axios from 'axios';

export default function ClassroomsPage() {

  const [FormData,setForm] = useState({
    
    Name:'',
    Capacity:''
  });

  const [msg,setmsg] = useState();

  const handleSubmit = async(e) =>{
    e.prevantDefault;
  

  const response  = await.axios.post("url")


return (
    <div className="container mt-4">
      <h1>Classrooms</h1>
    </div>
  );

}