import React, { useRef, useState } from 'react';
import './App.css';

function App() {
  const [courses, setCourses] = useState(["Programowanie w C#", "Angular dla początkujących", "Kurs Django"]);
  const fullName = useRef<HTMLInputElement>(null);
  const courseId = useRef<HTMLInputElement>(null);
  return (
    <div className='container'>
      <h2>Liczba kursów: {courses.length}</h2>
      <ol>
        {courses.map(el=><li>{el}</li>)}
      </ol>
      <form>
        <div className="form-group mt-3">
          <label>Imię i nazwisko</label>
          <input type="text" className='form-control' ref={fullName}></input>
        </div>
        <div className="form-group mt-3">
          <label>Numer kursu</label>
          <input type="number" className='form-control' ref={courseId}></input>
        </div>
        <div className="form-group mt-3">
          <input type="button" className="btn btn-primary" value={"Zapisz do kursu"} onClick={()=>{applyToCourse()}}/>
        </div>
      </form>
    </div>
  );

  function applyToCourse(){
    console.log(fullName.current)
    if(fullName.current != null && courseId.current != null){
      console.log("test");
      if(parseInt(courseId.current.value) > 3 || parseInt(courseId.current.value) < 1){
        console.log("Nieprawidłowy numer kursu");
      }else{
        console.log(fullName.current.value + courses[parseInt(courseId.current.value)-1]);
      }
    }
  }
}

export default App;
