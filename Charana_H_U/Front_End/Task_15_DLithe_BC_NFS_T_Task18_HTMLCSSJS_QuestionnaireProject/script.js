const quizQuestions = [
    {
        question: "Which language runs in a web browser?",
        a: "Java",
        b: "C",
        c: "Python",
        d: "javascript",
        correct: "d",
    },
    {
        question: "What does CSS stand for?",
        a: "Central Style Sheets",
        b: "Cascading Style Sheets",
        c: "Cascading Simple Sheets",
        d: "Cars SUVs Sailboats",
        correct: "b",
    },
    {
        question: "What does HTML stand for?",
        a: "Hypertext Markup Language",
        b: "Hypertext Markdown Language",
        c: "Hyperloop Machine Language",
        d: "Helicopters Terminals Motorboats Lamborginis",
        correct: "a",
    },
    {
        question: "What year was JavaScript launched?",
        a: "1996",
        b: "1995",
        c: "1994",
        d: "none of the above",
        correct: "b",
    },


];

const quiz = document.getElementById('quiz')

const answerEls = document.querySelectorAll('.answer')

const questionEl = document.getElementById('question')

const a_text = document.getElementById('a_text')

const b_text = document.getElementById('b_text')

const c_text = document.getElementById('c_text')

const d_text = document.getElementById('d_text')

const submitBtn = document.getElementById('submit')


let currentQuiz = 0

//inittially score is 0
let score = 0 

loadQuiz()

function loadQuiz() {

    deselectAnswers()

    const currentQuizQuestions = quizQuestions[currentQuiz]

    questionEl.innerText = currentQuizQuestions.question
    a_text.innerText = currentQuizQuestions.a
    b_text.innerText = currentQuizQuestions.b
    c_text.innerText = currentQuizQuestions.c
    d_text.innerText = currentQuizQuestions.d
}

function deselectAnswers() {
    answerEls.forEach(answerEl => answerEl.checked = false)
}

function getSelected() {
    let answer
    answerEls.forEach(answerEl => {
        if (answerEl.checked) {
            answer = answerEl.id
        }
    })
    return answer
}


submitBtn.addEventListener('click', () => {
    const answer = getSelected()
    if (answer) {
        if (answer === quizQuestions[currentQuiz].correct) {
            score++
        }

        currentQuiz++

        if (currentQuiz < quizQuestions.length) {
            loadQuiz()
        } 
        else {
            quiz.innerHTML = `
           <h2>You answered ${score}/${quizQuestions.length} questions correctly</h2>

           <button onclick="location.reload()">Reload</button>
           `
        }
    }
})