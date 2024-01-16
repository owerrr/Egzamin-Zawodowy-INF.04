package com.example.arkusz_app1

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.ArrayAdapter
import android.widget.Button
import android.widget.EditText
import android.widget.ListView

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val elementList = findViewById<ListView>(R.id.ListView_Main);
        val newElement_Button = findViewById<Button>(R.id.Button_AddElement);
        val newElement_Input = findViewById<EditText>(R.id.EditText_NewElement);
        val default_items = resources.getStringArray(R.array.app_default_listview_values);
        val list_items = arrayListOf<String>();
        default_items.forEach {
            list_items.add(it);
        }
        if(elementList !== null){
            val adapter = ArrayAdapter<String>(this, android.R.layout.simple_list_item_1, list_items);
            elementList.adapter = adapter;
            if(newElement_Button !== null){
                newElement_Button.setOnClickListener {
                    if(newElement_Input !== null){
                        val text = newElement_Input.text.toString();
                        if(text.trim().length > 0){
                            list_items.add(text);
                            adapter.notifyDataSetChanged();
                            newElement_Input.setText("");
                        }else{

                        }
                    }
                }
            }
        }
    }
}