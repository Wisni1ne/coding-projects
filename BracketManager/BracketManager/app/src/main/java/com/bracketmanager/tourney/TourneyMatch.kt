package com.bracketmanager.tourney

import android.os.Bundle
import androidx.appcompat.app.AppCompatActivity
import com.bracketmanager.R
import com.bracketmanager.main.MainApp
import com.bracketmanager.models.MatchModel
import kotlinx.android.synthetic.main.tourney_match.*
import kotlinx.android.synthetic.main.tourney_match.view.*
import org.jetbrains.anko.AnkoLogger

class TourneyMatch : AppCompatActivity(), AnkoLogger {

    var match = MatchModel()

    lateinit var app: MainApp

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.tourney_match)

        app = application as MainApp

        match = intent.extras?.getParcelable<MatchModel>("match_edit")!!

        aMatch.nameTopText.setText(match.nameOne.userid)
        aMatch.nameBotText.setText(match.nameTwo.userid)
        aMatch.scoreTop.setText(match.scoreOne)
        aMatch.scoreBot.setText(match.scoreTwo)
        roundText.roundTitle.text = "Round " + match.round.toString()
        aMatch.scoreTop.setEnabled(true)
        aMatch.scoreBot.setEnabled(true)

        buttonFinish.setOnClickListener() {

            match.scoreOne = aMatch.scoreTop.getText().toString()
            match.scoreTwo = aMatch.scoreBot.getText().toString()
            app.matches.update(match.copy())

            setResult(AppCompatActivity.RESULT_OK)
            finish()
        }

    }

}