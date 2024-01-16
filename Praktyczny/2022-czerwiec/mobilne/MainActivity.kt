package com.example.arkusz_2021_czerwiec_mobilna

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.TextView

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val button_LikeImage = findViewById<Button>(R.id.button_LikeImage)
        val button_DislikeImage = findViewById<Button>(R.id.button_DislikeImage)
        val textView_LikeCounter = findViewById<TextView>(R.id.textView_LikeCounter);
        var likeCount = 0;
        if(button_LikeImage !== null && textView_LikeCounter !== null && button_DislikeImage !== null){
            button_LikeImage.setOnClickListener {
                likeCount++;
                textView_LikeCounter.setText(likeCount.toString()+" polubień");
            }
            button_DislikeImage.setOnClickListener {
                if(likeCount > 0) likeCount--;
                textView_LikeCounter.setText(likeCount.toString()+" polubień");
            }
        }
    }
}